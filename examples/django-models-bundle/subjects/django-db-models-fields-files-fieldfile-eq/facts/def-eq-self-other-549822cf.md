# Fact 549822cf

Store id: c21a4079-49df-4cd7-8207-76cf29ebfefc

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:31:57.3371560+00:00`

## Data

```json
{
  "end_line": 32,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 27,
  "symbol": "FieldFile.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":27,"selector":"L27-L32","symbol":"FieldFile.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 32,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 27,
    "symbol": "FieldFile.__eq__"
  },
  "id": "c21a4079-49df-4cd7-8207-76cf29ebfefc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3371560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 27,
        "selector": "L27-L32",
        "symbol": "FieldFile.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "5d4b6b0a-b7b2-4ed7-aa5f-09f8d2f73d0a",
  "subject_name": "django/db/models/fields/files::FieldFile.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
