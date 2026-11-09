# Fact f0c79ee2

Store id: 0d2fa56a-a1b4-403f-b770-c6591cabe24a

## Text

```text
def has_filters(self)
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
- posted_at: `2026-11-09T23:44:58.6648000+00:00`

## Data

```json
{
  "end_line": 659,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 658,
  "symbol": "Query.has_filters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":658,"selector":"L658-L659","symbol":"Query.has_filters"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.has_filters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 659,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 658,
    "symbol": "Query.has_filters"
  },
  "id": "0d2fa56a-a1b4-403f-b770-c6591cabe24a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.6648000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 658,
        "selector": "L658-L659",
        "symbol": "Query.has_filters"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "722b50a5-e7c6-4dad-a4ac-536dd46c1703",
  "subject_name": "django/db/models/sql/query::Query.has_filters",
  "tags": [
    "entity:method"
  ],
  "text": "def has_filters(self)"
}
```
