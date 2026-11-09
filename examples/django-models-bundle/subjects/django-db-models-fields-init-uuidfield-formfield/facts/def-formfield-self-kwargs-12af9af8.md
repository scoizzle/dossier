# Fact 12af9af8

Store id: 1115e755-0121-41a9-bdf9-caa216cc0fcf

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
- posted_at: `2026-11-09T23:31:56.8880680+00:00`

## Data

```json
{
  "end_line": 2871,
  "entity_kind": "method",
  "parent": "UUIDField",
  "start_line": 2865,
  "symbol": "UUIDField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2865,"selector":"L2865-L2871","symbol":"UUIDField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::UUIDField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2871,
    "entity_kind": "method",
    "parent": "UUIDField",
    "start_line": 2865,
    "symbol": "UUIDField.formfield"
  },
  "id": "1115e755-0121-41a9-bdf9-caa216cc0fcf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8880680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2865,
        "selector": "L2865-L2871",
        "symbol": "UUIDField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "ee0bfc46-e1c8-468c-b842-6c4751c3918c",
  "subject_name": "django/db/models/fields/__init__::UUIDField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
