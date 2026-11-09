# Fact e525fd7c

Store id: f3eeaa80-648a-4bb0-b473-1febe42cb108

## Text

```text
def process_rhs(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:43.6749430+00:00`

## Data

```json
{
  "end_line": 312,
  "entity_kind": "method",
  "parent": "CaseInsensitiveMixin",
  "start_line": 308,
  "symbol": "CaseInsensitiveMixin.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":308,"selector":"L308-L312","symbol":"CaseInsensitiveMixin.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::CaseInsensitiveMixin.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 312,
    "entity_kind": "method",
    "parent": "CaseInsensitiveMixin",
    "start_line": 308,
    "symbol": "CaseInsensitiveMixin.process_rhs"
  },
  "id": "f3eeaa80-648a-4bb0-b473-1febe42cb108",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6749430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 308,
        "selector": "L308-L312",
        "symbol": "CaseInsensitiveMixin.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "388efee0-544e-4ea7-afbc-7111624b40a5",
  "subject_name": "django/db/models/fields/json::CaseInsensitiveMixin.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
