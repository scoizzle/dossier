# Fact e15d04e8

Store id: dfef9593-c65e-4480-b09e-4dbacdec0294

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
- posted_at: `2026-11-09T23:44:56.0416930+00:00`

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
  "id": "dfef9593-c65e-4480-b09e-4dbacdec0294",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.0416930+00:00"
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
  "subject_id": "2286b408-1892-4c40-9ee8-6c0b713ef787",
  "subject_name": "django/db/models/query::QuerySet._filter_or_exclude_inplace",
  "tags": [
    "entity:method"
  ],
  "text": "def _filter_or_exclude_inplace(self, negate, args, kwargs)"
}
```
