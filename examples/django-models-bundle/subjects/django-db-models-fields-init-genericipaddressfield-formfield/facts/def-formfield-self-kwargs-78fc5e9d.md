# Fact 78fc5e9d

Store id: b7c306bc-f5ad-48ec-a803-8dc52edc61e7

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
- posted_at: `2026-11-09T22:39:42.5902900+00:00`

## Data

```json
{
  "end_line": 2384,
  "entity_kind": "method",
  "parent": "GenericIPAddressField",
  "start_line": 2377,
  "symbol": "GenericIPAddressField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2377,"selector":"L2377-L2384","symbol":"GenericIPAddressField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::GenericIPAddressField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2384,
    "entity_kind": "method",
    "parent": "GenericIPAddressField",
    "start_line": 2377,
    "symbol": "GenericIPAddressField.formfield"
  },
  "id": "b7c306bc-f5ad-48ec-a803-8dc52edc61e7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5902900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2377,
        "selector": "L2377-L2384",
        "symbol": "GenericIPAddressField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "8b2212d2-9372-462b-972a-f571b9a37a80",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
