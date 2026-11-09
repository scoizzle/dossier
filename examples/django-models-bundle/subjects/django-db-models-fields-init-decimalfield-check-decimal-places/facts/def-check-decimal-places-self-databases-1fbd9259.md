# Fact 1fbd9259

Store id: 1cbaa358-1eaa-4a2c-afbc-8731c6bf5753

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
- posted_at: `2026-11-09T22:39:42.4474230+00:00`

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
  "id": "1cbaa358-1eaa-4a2c-afbc-8731c6bf5753",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4474230+00:00"
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
  "subject_id": "98bbc187-a7db-4593-badb-5f89e5420ec2",
  "subject_name": "django/db/models/fields/__init__::DecimalField._check_decimal_places",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_decimal_places(self, databases)"
}
```
