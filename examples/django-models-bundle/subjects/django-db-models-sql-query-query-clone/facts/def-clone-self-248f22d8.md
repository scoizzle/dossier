# Fact 248f22d8

Store id: aad2df52-f50d-4f4f-a61e-dbdbbd174c6f

## Text

```text
def clone(self)
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
- posted_at: `2026-11-09T22:39:51.2437760+00:00`

## Data

```json
{
  "end_line": 430,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 387,
  "symbol": "Query.clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":387,"selector":"L387-L430","symbol":"Query.clone"}`

## Items

```json
[
  {
    "text": "Return a copy of the current Query. A lightweight alternative to deepcopy().",
    "locator": {
      "line": 388
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 430,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 387,
    "symbol": "Query.clone"
  },
  "id": "aad2df52-f50d-4f4f-a61e-dbdbbd174c6f",
  "items": [
    {
      "locator": {
        "line": 388
      },
      "text": "Return a copy of the current Query. A lightweight alternative to deepcopy()."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2437760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 387,
        "selector": "L387-L430",
        "symbol": "Query.clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d0d6c3ec-62aa-42ad-81d7-448960acddd5",
  "subject_name": "django/db/models/sql/query::Query.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self)"
}
```
