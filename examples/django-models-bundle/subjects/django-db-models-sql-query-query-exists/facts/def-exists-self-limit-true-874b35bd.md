# Fact 874b35bd

Store id: 587f0476-1668-449b-8b38-702b099c06ef

## Text

```text
def exists(self, limit=True)
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
- posted_at: `2026-11-09T22:39:51.2661080+00:00`

## Data

```json
{
  "end_line": 681,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 661,
  "symbol": "Query.exists"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":661,"selector":"L661-L681","symbol":"Query.exists"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.exists](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 681,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 661,
    "symbol": "Query.exists"
  },
  "id": "587f0476-1668-449b-8b38-702b099c06ef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2661080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 661,
        "selector": "L661-L681",
        "symbol": "Query.exists"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "783b1460-4db8-4f2d-8634-8e1d0584f43f",
  "subject_name": "django/db/models/sql/query::Query.exists",
  "tags": [
    "entity:method"
  ],
  "text": "def exists(self, limit=True)"
}
```
