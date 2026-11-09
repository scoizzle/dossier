# Fact 472d9cb5

Store id: 7d00125f-5302-404e-829f-0c750df1effa

## Text

```text
def set_attributes_from_name(self, name)
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
- posted_at: `2026-11-09T22:39:42.3342100+00:00`

## Data

```json
{
  "end_line": 982,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 977,
  "symbol": "Field.set_attributes_from_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":977,"selector":"L977-L982","symbol":"Field.set_attributes_from_name"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.set_attributes_from_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 982,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 977,
    "symbol": "Field.set_attributes_from_name"
  },
  "id": "7d00125f-5302-404e-829f-0c750df1effa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3342100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 977,
        "selector": "L977-L982",
        "symbol": "Field.set_attributes_from_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "330dec41-fed8-475d-b28c-2675255a93f5",
  "subject_name": "django/db/models/fields/__init__::Field.set_attributes_from_name",
  "tags": [
    "entity:method"
  ],
  "text": "def set_attributes_from_name(self, name)"
}
```
