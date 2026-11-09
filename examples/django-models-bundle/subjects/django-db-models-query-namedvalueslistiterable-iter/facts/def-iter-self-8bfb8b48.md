# Fact 8bfb8b48

Store id: 8ce80491-b7fa-43f8-bc67-007bcf6bb8a5

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
- posted_at: `2026-11-09T22:39:49.2517440+00:00`

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
  "id": "8ce80491-b7fa-43f8-bc67-007bcf6bb8a5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.2517440+00:00"
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
  "subject_id": "2dbf7500-d7d7-4add-92f6-15247087ae58",
  "subject_name": "django/db/models/query::NamedValuesListIterable.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
