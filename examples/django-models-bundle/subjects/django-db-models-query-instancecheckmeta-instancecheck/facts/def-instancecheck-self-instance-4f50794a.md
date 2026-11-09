# Fact 4f50794a

Store id: 084f32c4-9749-4156-9422-849faa735e80

## Text

```text
def __instancecheck__(self, instance)
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
- posted_at: `2026-11-09T22:39:49.7576600+00:00`

## Data

```json
{
  "end_line": 2397,
  "entity_kind": "method",
  "parent": "InstanceCheckMeta",
  "start_line": 2396,
  "symbol": "InstanceCheckMeta.__instancecheck__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2396,"selector":"L2396-L2397","symbol":"InstanceCheckMeta.__instancecheck__"}`

## Referenced by

None.

## Subject

[django/db/models/query::InstanceCheckMeta.__instancecheck__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2397,
    "entity_kind": "method",
    "parent": "InstanceCheckMeta",
    "start_line": 2396,
    "symbol": "InstanceCheckMeta.__instancecheck__"
  },
  "id": "084f32c4-9749-4156-9422-849faa735e80",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7576600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2396,
        "selector": "L2396-L2397",
        "symbol": "InstanceCheckMeta.__instancecheck__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f48a9c66-f343-4ec8-b888-a7fa6f0f5785",
  "subject_name": "django/db/models/query::InstanceCheckMeta.__instancecheck__",
  "tags": [
    "entity:method"
  ],
  "text": "def __instancecheck__(self, instance)"
}
```
