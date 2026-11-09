# Fact 3e7d1a3a

Store id: e2123519-0781-4ee8-ad23-1b27df780669

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
- posted_at: `2026-11-09T23:44:50.0822380+00:00`

## Data

```json
{
  "end_line": 1425,
  "entity_kind": "method",
  "parent": "DateTimeCheckMixin",
  "start_line": 1424,
  "symbol": "DateTimeCheckMixin._check_fix_default_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1424,"selector":"L1424-L1425","symbol":"DateTimeCheckMixin._check_fix_default_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeCheckMixin._check_fix_default_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1425,
    "entity_kind": "method",
    "parent": "DateTimeCheckMixin",
    "start_line": 1424,
    "symbol": "DateTimeCheckMixin._check_fix_default_value"
  },
  "id": "e2123519-0781-4ee8-ad23-1b27df780669",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0822380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1424,
        "selector": "L1424-L1425",
        "symbol": "DateTimeCheckMixin._check_fix_default_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "5a77d74e-6e11-4209-9665-b369f0c10862",
  "subject_name": "django/db/models/fields/__init__::DateTimeCheckMixin._check_fix_default_value",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_fix_default_value(self)"
}
```
