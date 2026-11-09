# Fact f1b8d358

Store id: 339d430c-317a-400e-9497-f44d34d55c97

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
- posted_at: `2026-11-09T22:39:51.2899760+00:00`

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
  "id": "339d430c-317a-400e-9497-f44d34d55c97",
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
    "posted_at": "2026-11-09T22:39:51.2899760+00:00"
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
  "subject_id": "f5cd54c4-1e2c-4e16-bf0b-4496b0d155b4",
  "subject_name": "django/db/models/sql/query::Query.ref_alias",
  "tags": [
    "entity:method"
  ],
  "text": "def ref_alias(self, alias)"
}
```
