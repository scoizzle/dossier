# Fact 4d1d0627

Store id: 82cb8e40-9615-4759-85a5-9db8abb02a8b

## Text

```text
def _combinator_query(self, combinator, *other_qs, all=False)
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
- posted_at: `2026-11-09T23:44:56.0471570+00:00`

## Data

```json
{
  "end_line": 1758,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1748,
  "symbol": "QuerySet._combinator_query"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1748,"selector":"L1748-L1758","symbol":"QuerySet._combinator_query"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._combinator_query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1758,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1748,
    "symbol": "QuerySet._combinator_query"
  },
  "id": "82cb8e40-9615-4759-85a5-9db8abb02a8b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.0471570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1748,
        "selector": "L1748-L1758",
        "symbol": "QuerySet._combinator_query"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "7edfa48c-24d7-4bd5-ac46-336876f857c5",
  "subject_name": "django/db/models/query::QuerySet._combinator_query",
  "tags": [
    "entity:method"
  ],
  "text": "def _combinator_query(self, combinator, *other_qs, all=False)"
}
```
