# Fact 5bd6196f

Store id: 7712d447-fb15-44e6-ae3d-0884bab70ede

## Text

```text
def _check_primary_key(self)
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
- posted_at: `2026-11-09T23:44:50.3161430+00:00`

## Data

```json
{
  "end_line": 2897,
  "entity_kind": "method",
  "parent": "AutoFieldMixin",
  "start_line": 2887,
  "symbol": "AutoFieldMixin._check_primary_key"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2887,"selector":"L2887-L2897","symbol":"AutoFieldMixin._check_primary_key"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMixin._check_primary_key](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2897,
    "entity_kind": "method",
    "parent": "AutoFieldMixin",
    "start_line": 2887,
    "symbol": "AutoFieldMixin._check_primary_key"
  },
  "id": "7712d447-fb15-44e6-ae3d-0884bab70ede",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3161430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2887,
        "selector": "L2887-L2897",
        "symbol": "AutoFieldMixin._check_primary_key"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "03900da2-8cf2-44e3-962b-3c65272863ec",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin._check_primary_key",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_primary_key(self)"
}
```
