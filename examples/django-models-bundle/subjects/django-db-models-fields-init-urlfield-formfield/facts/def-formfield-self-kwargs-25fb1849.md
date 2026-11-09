# Fact 25fb1849

Store id: b8fa4a44-23dc-445a-a47d-394092c4f18a

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
- posted_at: `2026-11-09T23:44:50.2733490+00:00`

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
  "id": "b8fa4a44-23dc-445a-a47d-394092c4f18a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2733490+00:00"
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
  "subject_id": "37625439-504c-4d56-8f9f-d83db926bafe",
  "subject_name": "django/db/models/fields/__init__::URLField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
