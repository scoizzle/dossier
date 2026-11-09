# Fact 8bfb8b48

Store id: b7c3dd22-a6c8-48b9-b400-00fa05549c0b

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
- posted_at: `2026-11-09T23:32:04.2778720+00:00`

## Data

```json
{
  "end_line": 324,
  "entity_kind": "method",
  "parent": "NamedValuesListIterable",
  "start_line": 310,
  "symbol": "NamedValuesListIterable.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":310,"selector":"L310-L324","symbol":"NamedValuesListIterable.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::NamedValuesListIterable.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 324,
    "entity_kind": "method",
    "parent": "NamedValuesListIterable",
    "start_line": 310,
    "symbol": "NamedValuesListIterable.__iter__"
  },
  "id": "b7c3dd22-a6c8-48b9-b400-00fa05549c0b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2778720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 310,
        "selector": "L310-L324",
        "symbol": "NamedValuesListIterable.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "72cb0d30-26ea-41a5-ac51-2a005b853d7d",
  "subject_name": "django/db/models/query::NamedValuesListIterable.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
