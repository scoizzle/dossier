# Fact 25fb1849

Store id: 29c77d5a-2c91-4028-9814-6bc5a6daf3ae

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
- posted_at: `2026-11-09T22:39:42.6849460+00:00`

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
  "id": "29c77d5a-2c91-4028-9814-6bc5a6daf3ae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6849460+00:00"
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
  "subject_id": "ef016fb2-d6bd-43da-be8a-1950ba156c69",
  "subject_name": "django/db/models/fields/__init__::URLField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
