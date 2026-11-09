# Fact 8bd527f3

Store id: a92932cb-184a-4db1-b47a-6a02d5111e80

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
- posted_at: `2026-11-09T23:31:56.8299800+00:00`

## Data

```json
{
  "end_line": 2716,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2710,
  "symbol": "TimeField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2710,"selector":"L2710-L2716","symbol":"TimeField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2716,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2710,
    "symbol": "TimeField.formfield"
  },
  "id": "a92932cb-184a-4db1-b47a-6a02d5111e80",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8299800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2710,
        "selector": "L2710-L2716",
        "symbol": "TimeField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "6156cf78-756e-4090-9e2d-073879aeb14a",
  "subject_name": "django/db/models/fields/__init__::TimeField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
