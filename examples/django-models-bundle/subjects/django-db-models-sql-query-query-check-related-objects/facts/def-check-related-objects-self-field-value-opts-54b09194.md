# Fact 54b09194

Store id: 6d2f774b-66a3-4074-a759-6e3ecfad3a92

## Text

```text
def check_related_objects(self, field, value, opts)
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
- posted_at: `2026-11-09T22:39:51.3596930+00:00`

## Data

```json
{
  "end_line": 1399,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1378,
  "symbol": "Query.check_related_objects"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1378,"selector":"L1378-L1399","symbol":"Query.check_related_objects"}`

## Items

```json
[
  {
    "text": "Check the type of object passed to query relations.",
    "locator": {
      "line": 1379
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.check_related_objects](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1399,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1378,
    "symbol": "Query.check_related_objects"
  },
  "id": "6d2f774b-66a3-4074-a759-6e3ecfad3a92",
  "items": [
    {
      "locator": {
        "line": 1379
      },
      "text": "Check the type of object passed to query relations."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3596930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1378,
        "selector": "L1378-L1399",
        "symbol": "Query.check_related_objects"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "013696b1-165a-4731-af47-948daf2ac697",
  "subject_name": "django/db/models/sql/query::Query.check_related_objects",
  "tags": [
    "entity:method"
  ],
  "text": "def check_related_objects(self, field, value, opts)"
}
```
