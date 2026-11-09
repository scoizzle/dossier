# Fact fb594d84

Store id: a5963425-651a-4480-8605-f9aeb870fa28

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T22:39:49.2239620+00:00`

## Data

```json
{
  "end_line": 284,
  "entity_kind": "method",
  "parent": "ValuesIterable",
  "start_line": 266,
  "symbol": "ValuesIterable.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":266,"selector":"L266-L284","symbol":"ValuesIterable.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::ValuesIterable.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 284,
    "entity_kind": "method",
    "parent": "ValuesIterable",
    "start_line": 266,
    "symbol": "ValuesIterable.__iter__"
  },
  "id": "a5963425-651a-4480-8605-f9aeb870fa28",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.2239620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 266,
        "selector": "L266-L284",
        "symbol": "ValuesIterable.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f7e1a277-73db-4ac9-9444-2b36a2a7f385",
  "subject_name": "django/db/models/query::ValuesIterable.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
