# Fact 25fb1849

Store id: 0700c71b-1273-42ac-bc40-41b713a935d7

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
- posted_at: `2026-11-09T23:31:56.8383520+00:00`

## Data

```json
{
  "end_line": 2741,
  "entity_kind": "method",
  "parent": "URLField",
  "start_line": 2733,
  "symbol": "URLField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2733,"selector":"L2733-L2741","symbol":"URLField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::URLField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2741,
    "entity_kind": "method",
    "parent": "URLField",
    "start_line": 2733,
    "symbol": "URLField.formfield"
  },
  "id": "0700c71b-1273-42ac-bc40-41b713a935d7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8383520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2733,
        "selector": "L2733-L2741",
        "symbol": "URLField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "2106967c-ce51-4148-ac10-f45349ab50f4",
  "subject_name": "django/db/models/fields/__init__::URLField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
