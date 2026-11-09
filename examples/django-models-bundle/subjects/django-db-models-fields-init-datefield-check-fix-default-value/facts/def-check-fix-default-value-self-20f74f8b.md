# Fact 20f74f8b

Store id: 6175bc37-0dc9-4d73-9e2f-bca731909689

## Text

```text
def _check_fix_default_value(self)
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
- posted_at: `2026-11-09T23:44:50.0872060+00:00`

## Data

```json
{
  "end_line": 1504,
  "entity_kind": "method",
  "parent": "DateField",
  "start_line": 1487,
  "symbol": "DateField._check_fix_default_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1487,"selector":"L1487-L1504","symbol":"DateField._check_fix_default_value"}`

## Items

```json
[
  {
    "text": "Warn that using an actual date or datetime value is probably wrong; it's only evaluated on server startup.",
    "locator": {
      "line": 1488
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField._check_fix_default_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1504,
    "entity_kind": "method",
    "parent": "DateField",
    "start_line": 1487,
    "symbol": "DateField._check_fix_default_value"
  },
  "id": "6175bc37-0dc9-4d73-9e2f-bca731909689",
  "items": [
    {
      "locator": {
        "line": 1488
      },
      "text": "Warn that using an actual date or datetime value is probably wrong; it's only evaluated on server startup."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0872060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1487,
        "selector": "L1487-L1504",
        "symbol": "DateField._check_fix_default_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "afc44d03-ad72-4bb0-84ab-1ea6880034a5",
  "subject_name": "django/db/models/fields/__init__::DateField._check_fix_default_value",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_fix_default_value(self)"
}
```
