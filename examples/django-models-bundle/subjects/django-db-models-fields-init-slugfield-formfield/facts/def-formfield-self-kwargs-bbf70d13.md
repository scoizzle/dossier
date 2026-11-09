# Fact bbf70d13

Store id: d6ac0bbd-37cf-471e-93c8-6094b248da36

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
- posted_at: `2026-11-09T23:31:56.7902790+00:00`

## Data

```json
{
  "end_line": 2521,
  "entity_kind": "method",
  "parent": "SlugField",
  "start_line": 2514,
  "symbol": "SlugField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2514,"selector":"L2514-L2521","symbol":"SlugField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::SlugField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2521,
    "entity_kind": "method",
    "parent": "SlugField",
    "start_line": 2514,
    "symbol": "SlugField.formfield"
  },
  "id": "d6ac0bbd-37cf-471e-93c8-6094b248da36",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7902790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2514,
        "selector": "L2514-L2521",
        "symbol": "SlugField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "542a0f6d-f2bb-4a64-8697-9be717b77952",
  "subject_name": "django/db/models/fields/__init__::SlugField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
