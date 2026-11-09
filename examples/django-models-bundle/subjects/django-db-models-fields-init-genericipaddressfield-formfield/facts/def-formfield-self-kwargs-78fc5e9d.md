# Fact 78fc5e9d

Store id: 6b8c021a-db55-4318-b3e7-448907825ff9

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
- posted_at: `2026-11-09T23:31:56.7511430+00:00`

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
  "id": "6b8c021a-db55-4318-b3e7-448907825ff9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7511430+00:00"
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
  "subject_id": "56b8d136-680a-49ea-856c-9ad659df5cbd",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
