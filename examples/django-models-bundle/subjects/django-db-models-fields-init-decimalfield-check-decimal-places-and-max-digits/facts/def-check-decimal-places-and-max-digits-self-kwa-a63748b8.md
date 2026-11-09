# Fact a63748b8

Store id: 91b21922-95e3-4fad-93d5-82b7490eddbc

## Text

```text
def _check_decimal_places_and_max_digits(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:56.6258940+00:00`

## Data

```json
{
  "end_line": 1869,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1858,
  "symbol": "DecimalField._check_decimal_places_and_max_digits"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1858,"selector":"L1858-L1869","symbol":"DecimalField._check_decimal_places_and_max_digits"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField._check_decimal_places_and_max_digits](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1869,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1858,
    "symbol": "DecimalField._check_decimal_places_and_max_digits"
  },
  "id": "91b21922-95e3-4fad-93d5-82b7490eddbc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6258940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1858,
        "selector": "L1858-L1869",
        "symbol": "DecimalField._check_decimal_places_and_max_digits"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "6c43fe2c-293a-47b2-9fc1-bd9e5802450c",
  "subject_name": "django/db/models/fields/__init__::DecimalField._check_decimal_places_and_max_digits",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_decimal_places_and_max_digits(self, **kwargs)"
}
```
