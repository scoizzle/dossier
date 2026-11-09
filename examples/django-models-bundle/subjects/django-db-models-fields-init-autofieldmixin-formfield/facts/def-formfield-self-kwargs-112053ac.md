# Fact 112053ac

Store id: 4ef75156-61fa-4bd2-8ada-721bfac26987

## Text

```text
def formfield(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:42.7401520+00:00`

## Data

```json
{
  "end_line": 2928,
  "entity_kind": "method",
  "parent": "AutoFieldMixin",
  "start_line": 2927,
  "symbol": "AutoFieldMixin.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2927,"selector":"L2927-L2928","symbol":"AutoFieldMixin.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMixin.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2928,
    "entity_kind": "method",
    "parent": "AutoFieldMixin",
    "start_line": 2927,
    "symbol": "AutoFieldMixin.formfield"
  },
  "id": "4ef75156-61fa-4bd2-8ada-721bfac26987",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7401520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2927,
        "selector": "L2927-L2928",
        "symbol": "AutoFieldMixin.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "ae133e47-4aba-4c6c-b676-72eddad46c49",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
