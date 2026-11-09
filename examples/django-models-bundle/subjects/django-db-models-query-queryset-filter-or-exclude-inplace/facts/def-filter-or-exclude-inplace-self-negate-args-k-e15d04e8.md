# Fact e15d04e8

Store id: 4fc806eb-6c9c-4d55-affd-42b2d709dfbe

## Text

```text
def _filter_or_exclude_inplace(self, negate, args, kwargs)
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
- posted_at: `2026-11-09T22:39:49.6149200+00:00`

## Data

```json
{
  "end_line": 1729,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1722,
  "symbol": "QuerySet._filter_or_exclude_inplace"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1722,"selector":"L1722-L1729","symbol":"QuerySet._filter_or_exclude_inplace"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._filter_or_exclude_inplace](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1729,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1722,
    "symbol": "QuerySet._filter_or_exclude_inplace"
  },
  "id": "4fc806eb-6c9c-4d55-affd-42b2d709dfbe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.6149200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1722,
        "selector": "L1722-L1729",
        "symbol": "QuerySet._filter_or_exclude_inplace"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c11349af-5fe7-47dd-81be-b32cb9bb0b37",
  "subject_name": "django/db/models/query::QuerySet._filter_or_exclude_inplace",
  "tags": [
    "entity:method"
  ],
  "text": "def _filter_or_exclude_inplace(self, negate, args, kwargs)"
}
```
