# Fact 7c75d3a2

Store id: 5ba1e3de-067e-469f-a8e0-b55fce8ceca8

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T23:44:50.1512130+00:00`

## Data

```json
{
  "end_line": 2096,
  "entity_kind": "method",
  "parent": "FilePathField",
  "start_line": 2095,
  "symbol": "FilePathField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2095,"selector":"L2095-L2096","symbol":"FilePathField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FilePathField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2096,
    "entity_kind": "method",
    "parent": "FilePathField",
    "start_line": 2095,
    "symbol": "FilePathField.get_internal_type"
  },
  "id": "5ba1e3de-067e-469f-a8e0-b55fce8ceca8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1512130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2095,
        "selector": "L2095-L2096",
        "symbol": "FilePathField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "2e02928d-e010-4a96-a6c9-5a7f2f3e8051",
  "subject_name": "django/db/models/fields/__init__::FilePathField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
