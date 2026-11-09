# Fact 56dc1185

Store id: 240564a9-c3e0-4cf5-97d1-38637deccd61

## Text

```text
def clear_select_fields(self)
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
- posted_at: `2026-11-09T23:32:07.0442610+00:00`

## Data

```json
{
  "end_line": 2249,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2241,
  "symbol": "Query.clear_select_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2241,"selector":"L2241-L2249","symbol":"Query.clear_select_fields"}`

## Items

```json
[
  {
    "text": "Clear the list of fields to select (but not extra_select columns). Some queryset types completely replace any existing list of select columns.",
    "locator": {
      "line": 2242
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.clear_select_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2249,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2241,
    "symbol": "Query.clear_select_fields"
  },
  "id": "240564a9-c3e0-4cf5-97d1-38637deccd61",
  "items": [
    {
      "locator": {
        "line": 2242
      },
      "text": "Clear the list of fields to select (but not extra_select columns). Some queryset types completely replace any existing list of select columns."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.0442610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2241,
        "selector": "L2241-L2249",
        "symbol": "Query.clear_select_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "558099b2-3c3e-4615-a0e1-4338d3fa6a75",
  "subject_name": "django/db/models/sql/query::Query.clear_select_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def clear_select_fields(self)"
}
```
