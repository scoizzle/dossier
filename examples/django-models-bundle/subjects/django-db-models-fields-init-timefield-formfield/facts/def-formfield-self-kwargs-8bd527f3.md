# Fact 8bd527f3

Store id: 1396a194-4f37-4bd8-8d44-096550a306c8

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
- posted_at: `2026-11-09T23:44:50.2665910+00:00`

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
  "id": "1396a194-4f37-4bd8-8d44-096550a306c8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2665910+00:00"
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
  "subject_id": "25e25560-063f-485c-8ee0-ab0ce8cc22bc",
  "subject_name": "django/db/models/fields/__init__::TimeField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
