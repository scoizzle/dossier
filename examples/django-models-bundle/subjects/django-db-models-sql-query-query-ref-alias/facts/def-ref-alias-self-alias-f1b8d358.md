# Fact f1b8d358

Store id: 3f419a77-98eb-48b9-9b26-3ab760817863

## Text

```text
def ref_alias(self, alias)
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
- posted_at: `2026-11-09T23:44:58.7144810+00:00`

## Data

```json
{
  "end_line": 928,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 926,
  "symbol": "Query.ref_alias"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":926,"selector":"L926-L928","symbol":"Query.ref_alias"}`

## Items

```json
[
  {
    "text": "Increases the reference count for this alias.",
    "locator": {
      "line": 927
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.ref_alias](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 928,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 926,
    "symbol": "Query.ref_alias"
  },
  "id": "3f419a77-98eb-48b9-9b26-3ab760817863",
  "items": [
    {
      "locator": {
        "line": 927
      },
      "text": "Increases the reference count for this alias."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.7144810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 926,
        "selector": "L926-L928",
        "symbol": "Query.ref_alias"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "90996211-ab5e-4fc8-8292-9581508f2d89",
  "subject_name": "django/db/models/sql/query::Query.ref_alias",
  "tags": [
    "entity:method"
  ],
  "text": "def ref_alias(self, alias)"
}
```
