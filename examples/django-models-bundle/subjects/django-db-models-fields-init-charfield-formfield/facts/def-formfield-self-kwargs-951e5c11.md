# Fact 951e5c11

Store id: d9d33c05-41da-4dfc-bdff-b4052377cc3b

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
- posted_at: `2026-11-09T22:39:42.3894410+00:00`

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
  "id": "d9d33c05-41da-4dfc-bdff-b4052377cc3b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3894410+00:00"
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
  "subject_id": "ad335c39-5906-4afc-81ab-0cdf9d10bdf8",
  "subject_name": "django/db/models/fields/__init__::CharField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
