# Fact e91b3369

Store id: ac3f090e-a878-49cf-9af1-3c2cc38e4939

## Text

```text
def _raw_delete(self, using)
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
- posted_at: `2026-11-09T23:44:55.9793680+00:00`

## Data

```json
{
  "end_line": 1404,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1397,
  "symbol": "QuerySet._raw_delete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1397,"selector":"L1397-L1404","symbol":"QuerySet._raw_delete"}`

## Items

```json
[
  {
    "text": "Delete objects found from the given queryset in single direct SQL query. No signals are sent and there is no protection for cascades.",
    "locator": {
      "line": 1398
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._raw_delete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1404,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1397,
    "symbol": "QuerySet._raw_delete"
  },
  "id": "ac3f090e-a878-49cf-9af1-3c2cc38e4939",
  "items": [
    {
      "locator": {
        "line": 1398
      },
      "text": "Delete objects found from the given queryset in single direct SQL query. No signals are sent and there is no protection for cascades."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9793680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1397,
        "selector": "L1397-L1404",
        "symbol": "QuerySet._raw_delete"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "0e568d3c-46c4-4827-9e85-9440916000fe",
  "subject_name": "django/db/models/query::QuerySet._raw_delete",
  "tags": [
    "entity:method"
  ],
  "text": "def _raw_delete(self, using)"
}
```
