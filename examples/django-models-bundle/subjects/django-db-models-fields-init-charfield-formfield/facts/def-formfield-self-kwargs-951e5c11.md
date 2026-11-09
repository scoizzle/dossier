# Fact 951e5c11

Store id: af12d720-f86a-4ccc-8f0e-b39e647b32b4

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
- posted_at: `2026-11-09T23:31:56.5603700+00:00`

## Data

```json
{
  "end_line": 1351,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1342,
  "symbol": "CharField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1342,"selector":"L1342-L1351","symbol":"CharField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1351,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1342,
    "symbol": "CharField.formfield"
  },
  "id": "af12d720-f86a-4ccc-8f0e-b39e647b32b4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5603700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1342,
        "selector": "L1342-L1351",
        "symbol": "CharField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "82a233f3-9a5c-44d0-be8b-239cffae7be2",
  "subject_name": "django/db/models/fields/__init__::CharField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
