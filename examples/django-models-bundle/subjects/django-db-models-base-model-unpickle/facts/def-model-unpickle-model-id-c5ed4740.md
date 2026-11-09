# Fact c5ed4740

Store id: ad8f4e55-ad25-4674-b1e3-098390411322

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
- posted_at: `2026-11-09T23:31:53.7760880+00:00`

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
  "id": "ad8f4e55-ad25-4674-b1e3-098390411322",
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
    "posted_at": "2026-11-09T23:31:53.7760880+00:00"
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
  "subject_id": "eaa023bd-9df3-481e-a8f3-b764b1520937",
  "subject_name": "django/db/models/base::model_unpickle",
  "tags": [
    "entity:function"
  ],
  "text": "def model_unpickle(model_id)"
}
```
