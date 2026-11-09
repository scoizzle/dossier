# Fact 1b76fef1

Store id: f505b1b0-6dca-4cb3-9b04-3798002f96a0

## Text

```text
def unref_alias(self, alias, amount=1)
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
- posted_at: `2026-11-09T23:32:06.8391550+00:00`

## Data

```json
{
  "end_line": 932,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 930,
  "symbol": "Query.unref_alias"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":930,"selector":"L930-L932","symbol":"Query.unref_alias"}`

## Items

```json
[
  {
    "text": "Decreases the reference count for this alias.",
    "locator": {
      "line": 931
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.unref_alias](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 932,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 930,
    "symbol": "Query.unref_alias"
  },
  "id": "f505b1b0-6dca-4cb3-9b04-3798002f96a0",
  "items": [
    {
      "locator": {
        "line": 931
      },
      "text": "Decreases the reference count for this alias."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.8391550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 930,
        "selector": "L930-L932",
        "symbol": "Query.unref_alias"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8eaac3d0-763a-4381-9517-a2467b381ca7",
  "subject_name": "django/db/models/sql/query::Query.unref_alias",
  "tags": [
    "entity:method"
  ],
  "text": "def unref_alias(self, alias, amount=1)"
}
```
