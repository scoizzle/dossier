# Fact 38c45945

Store id: 19a08aab-5137-494b-9280-9615dcf3a57b

## Text

```text
def alias(self, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:49.6515520+00:00`

## Data

```json
{
  "end_line": 1874,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1869,
  "symbol": "QuerySet.alias"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1869,"selector":"L1869-L1874","symbol":"QuerySet.alias"}`

## Items

```json
[
  {
    "text": "Return a query set with added aliases for extra data or aggregations.",
    "locator": {
      "line": 1870
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.alias](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1874,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1869,
    "symbol": "QuerySet.alias"
  },
  "id": "19a08aab-5137-494b-9280-9615dcf3a57b",
  "items": [
    {
      "locator": {
        "line": 1870
      },
      "text": "Return a query set with added aliases for extra data or aggregations."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.6515520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1869,
        "selector": "L1869-L1874",
        "symbol": "QuerySet.alias"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "2f6c2006-f126-4f22-af03-2154d6508c79",
  "subject_name": "django/db/models/query::QuerySet.alias",
  "tags": [
    "entity:method"
  ],
  "text": "def alias(self, *args, **kwargs)"
}
```
