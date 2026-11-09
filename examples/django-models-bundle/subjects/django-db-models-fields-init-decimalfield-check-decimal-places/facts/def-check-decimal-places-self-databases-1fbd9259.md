# Fact 1fbd9259

Store id: a9eb3254-54e9-4e37-9e9d-bda29288ea35

## Text

```text
def _check_decimal_places(self, databases)
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
- posted_at: `2026-11-09T23:44:50.1135050+00:00`

## Data

```json
{
  "end_line": 1813,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1772,
  "symbol": "DecimalField._check_decimal_places"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1772,"selector":"L1772-L1813","symbol":"DecimalField._check_decimal_places"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField._check_decimal_places](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1813,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1772,
    "symbol": "DecimalField._check_decimal_places"
  },
  "id": "a9eb3254-54e9-4e37-9e9d-bda29288ea35",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1135050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1772,
        "selector": "L1772-L1813",
        "symbol": "DecimalField._check_decimal_places"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "ea546814-7d12-49ee-8ef5-ad12db05b212",
  "subject_name": "django/db/models/fields/__init__::DecimalField._check_decimal_places",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_decimal_places(self, databases)"
}
```
