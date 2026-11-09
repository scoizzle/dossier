# Fact 75ec6ef9

Store id: b1bf6dbf-1bae-417b-955b-f1dde8585fef

## Text

```text
class AutoField(AutoFieldMixin, IntegerField, metaclass=AutoFieldMeta)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:42.7509700+00:00`

## Data

```json
{
  "end_line": 2968,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2963,
  "symbol": "AutoField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2963,"selector":"L2963-L2968","symbol":"AutoField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2968,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2963,
    "symbol": "AutoField"
  },
  "id": "b1bf6dbf-1bae-417b-955b-f1dde8585fef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7509700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2963,
        "selector": "L2963-L2968",
        "symbol": "AutoField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "8908ccbf-fd13-4a7c-875b-18d27776b03d",
  "subject_name": "django/db/models/fields/__init__::AutoField",
  "tags": [
    "entity:class"
  ],
  "text": "class AutoField(AutoFieldMixin, IntegerField, metaclass=AutoFieldMeta)"
}
```
