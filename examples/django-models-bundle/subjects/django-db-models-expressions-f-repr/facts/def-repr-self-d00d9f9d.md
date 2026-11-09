# Fact d00d9f9d

Store id: 90bb326f-7533-430c-a727-18c7f2c98210

## Text

```text
def __repr__(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.8317160+00:00`

## Data

```json
{
  "end_line": 895,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 894,
  "symbol": "F.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":894,"selector":"L894-L895","symbol":"F.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 895,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 894,
    "symbol": "F.__repr__"
  },
  "id": "90bb326f-7533-430c-a727-18c7f2c98210",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8317160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 894,
        "selector": "L894-L895",
        "symbol": "F.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "94eafbb7-9f97-4257-a811-fb6cd3534d20",
  "subject_name": "django/db/models/expressions::F.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
