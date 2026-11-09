# Fact 3405d50e

Store id: 569fce50-4c22-4f8d-8bda-d26633c1fd28

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
- posted_at: `2026-11-09T22:39:42.4416160+00:00`

## Data

```json
{
  "end_line": 1737,
  "entity_kind": "method",
  "parent": "DateTimeField",
  "start_line": 1731,
  "symbol": "DateTimeField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1731,"selector":"L1731-L1737","symbol":"DateTimeField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1737,
    "entity_kind": "method",
    "parent": "DateTimeField",
    "start_line": 1731,
    "symbol": "DateTimeField.formfield"
  },
  "id": "569fce50-4c22-4f8d-8bda-d26633c1fd28",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4416160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1731,
        "selector": "L1731-L1737",
        "symbol": "DateTimeField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1cadaae1-a87b-4f09-bab9-de9dbf49790c",
  "subject_name": "django/db/models/fields/__init__::DateTimeField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
