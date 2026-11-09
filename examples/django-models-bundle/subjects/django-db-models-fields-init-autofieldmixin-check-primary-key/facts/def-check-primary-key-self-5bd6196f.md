# Fact 5bd6196f

Store id: 59413ca8-562c-4eb8-aaf0-9c5ead6fe5f5

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
- posted_at: `2026-11-09T23:31:56.8952400+00:00`

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
  "id": "59413ca8-562c-4eb8-aaf0-9c5ead6fe5f5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8952400+00:00"
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
  "subject_id": "b9e47ae0-b3ae-4e62-b5c8-6bc9d019946a",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin._check_primary_key",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_primary_key(self)"
}
```
