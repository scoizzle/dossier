# Fact 44de6da1

Store id: 68bd2cb9-880e-4b09-883c-1b9306b6d7d2

## Text

```text
def delete_batch(self, pk_list, using)
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
- posted_at: `2026-11-09T22:39:51.7143580+00:00`

## Data

```json
{
  "end_line": 46,
  "entity_kind": "method",
  "parent": "DeleteQuery",
  "start_line": 27,
  "symbol": "DeleteQuery.delete_batch"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":27,"selector":"L27-L46","symbol":"DeleteQuery.delete_batch"}`

## Items

```json
[
  {
    "text": "Set up and execute delete queries for all the objects in pk_list.",
    "locator": {
      "line": 28
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::DeleteQuery.delete_batch](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 46,
    "entity_kind": "method",
    "parent": "DeleteQuery",
    "start_line": 27,
    "symbol": "DeleteQuery.delete_batch"
  },
  "id": "68bd2cb9-880e-4b09-883c-1b9306b6d7d2",
  "items": [
    {
      "locator": {
        "line": 28
      },
      "text": "Set up and execute delete queries for all the objects in pk_list."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.7143580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 27,
        "selector": "L27-L46",
        "symbol": "DeleteQuery.delete_batch"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "0ac79d38-00bf-4c18-b05c-adaf3ede965a",
  "subject_name": "django/db/models/sql/subqueries::DeleteQuery.delete_batch",
  "tags": [
    "entity:method"
  ],
  "text": "def delete_batch(self, pk_list, using)"
}
```
