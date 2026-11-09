# Fact 34304670

Store id: de581c6a-6c41-4d57-afd3-e882d3c19340

## Text

```text
def process_lhs(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:43.6728510+00:00`

## Data

```json
{
  "end_line": 306,
  "entity_kind": "method",
  "parent": "CaseInsensitiveMixin",
  "start_line": 302,
  "symbol": "CaseInsensitiveMixin.process_lhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":302,"selector":"L302-L306","symbol":"CaseInsensitiveMixin.process_lhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::CaseInsensitiveMixin.process_lhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 306,
    "entity_kind": "method",
    "parent": "CaseInsensitiveMixin",
    "start_line": 302,
    "symbol": "CaseInsensitiveMixin.process_lhs"
  },
  "id": "de581c6a-6c41-4d57-afd3-e882d3c19340",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6728510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 302,
        "selector": "L302-L306",
        "symbol": "CaseInsensitiveMixin.process_lhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "9c9d4dd0-70ea-46a8-b220-2c06750ab194",
  "subject_name": "django/db/models/fields/json::CaseInsensitiveMixin.process_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_lhs(self, compiler, connection)"
}
```
