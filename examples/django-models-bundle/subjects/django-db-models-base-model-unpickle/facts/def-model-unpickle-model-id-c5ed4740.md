# Fact c5ed4740

Store id: 6d03cc39-8777-49be-b661-0332dad638ce

## Text

```text
def model_unpickle(model_id)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.5577890+00:00`

## Data

```json
{
  "end_line": 2573,
  "entity_kind": "function",
  "parent": "base",
  "start_line": 2566,
  "symbol": "model_unpickle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2566,"selector":"L2566-L2573","symbol":"model_unpickle"}`

## Items

```json
[
  {
    "text": "Used to unpickle Model subclasses with deferred fields.",
    "locator": {
      "line": 2567
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::model_unpickle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2573,
    "entity_kind": "function",
    "parent": "base",
    "start_line": 2566,
    "symbol": "model_unpickle"
  },
  "id": "6d03cc39-8777-49be-b661-0332dad638ce",
  "items": [
    {
      "locator": {
        "line": 2567
      },
      "text": "Used to unpickle Model subclasses with deferred fields."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5577890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2566,
        "selector": "L2566-L2573",
        "symbol": "model_unpickle"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "7737a54d-b7db-4c6f-94af-e0070affabdc",
  "subject_name": "django/db/models/base::model_unpickle",
  "tags": [
    "entity:function"
  ],
  "text": "def model_unpickle(model_id)"
}
```
