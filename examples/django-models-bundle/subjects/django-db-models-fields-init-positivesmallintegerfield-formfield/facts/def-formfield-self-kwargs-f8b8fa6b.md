# Fact f8b8fa6b

Store id: bf727942-7215-40f2-8bb5-cd8531348e39

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
- posted_at: `2026-11-09T22:39:42.6195940+00:00`

## Data

```json
{
  "end_line": 2484,
  "entity_kind": "method",
  "parent": "PositiveSmallIntegerField",
  "start_line": 2478,
  "symbol": "PositiveSmallIntegerField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2478,"selector":"L2478-L2484","symbol":"PositiveSmallIntegerField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::PositiveSmallIntegerField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2484,
    "entity_kind": "method",
    "parent": "PositiveSmallIntegerField",
    "start_line": 2478,
    "symbol": "PositiveSmallIntegerField.formfield"
  },
  "id": "bf727942-7215-40f2-8bb5-cd8531348e39",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6195940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2478,
        "selector": "L2478-L2484",
        "symbol": "PositiveSmallIntegerField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "cef14267-41c7-4e86-9685-34b4c5e2e11b",
  "subject_name": "django/db/models/fields/__init__::PositiveSmallIntegerField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
