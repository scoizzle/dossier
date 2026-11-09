# Fact ff3a918b

Store id: 732ff7e0-266b-4b02-b720-2bfc9cdf4875

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
- posted_at: `2026-11-09T22:39:42.6090510+00:00`

## Data

```json
{
  "end_line": 2454,
  "entity_kind": "method",
  "parent": "PositiveBigIntegerField",
  "start_line": 2448,
  "symbol": "PositiveBigIntegerField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2448,"selector":"L2448-L2454","symbol":"PositiveBigIntegerField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::PositiveBigIntegerField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2454,
    "entity_kind": "method",
    "parent": "PositiveBigIntegerField",
    "start_line": 2448,
    "symbol": "PositiveBigIntegerField.formfield"
  },
  "id": "732ff7e0-266b-4b02-b720-2bfc9cdf4875",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6090510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2448,
        "selector": "L2448-L2454",
        "symbol": "PositiveBigIntegerField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "73114de8-9d1e-4a43-9f41-ecf9af955f13",
  "subject_name": "django/db/models/fields/__init__::PositiveBigIntegerField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
