# Fact f8b8fa6b

Store id: bb4e5752-abe8-4862-a685-1897598ac0f0

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
- posted_at: `2026-11-09T23:44:50.2246980+00:00`

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
  "id": "bb4e5752-abe8-4862-a685-1897598ac0f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2246980+00:00"
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
  "subject_id": "708fdcca-110b-48c6-af02-3cd3a20f293c",
  "subject_name": "django/db/models/fields/__init__::PositiveSmallIntegerField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
