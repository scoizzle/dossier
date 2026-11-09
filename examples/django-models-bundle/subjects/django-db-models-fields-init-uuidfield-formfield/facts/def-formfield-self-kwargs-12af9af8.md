# Fact 12af9af8

Store id: 61266f0d-0de7-458d-8372-c499759999dc

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
- posted_at: `2026-11-09T23:44:50.3092130+00:00`

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
  "id": "61266f0d-0de7-458d-8372-c499759999dc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3092130+00:00"
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
  "subject_id": "09a8c438-8273-40f7-8433-97bceff93412",
  "subject_name": "django/db/models/fields/__init__::UUIDField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
