# Fact 3405d50e

Store id: 57e1f33f-6578-4733-a0b9-ff0827144512

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
- posted_at: `2026-11-09T23:31:56.6069960+00:00`

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
  "id": "57e1f33f-6578-4733-a0b9-ff0827144512",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6069960+00:00"
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
  "subject_id": "e6c9940f-6564-4a72-9e33-88c62b4511be",
  "subject_name": "django/db/models/fields/__init__::DateTimeField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
