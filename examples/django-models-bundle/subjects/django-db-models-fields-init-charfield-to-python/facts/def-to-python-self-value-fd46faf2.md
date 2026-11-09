# Fact fd46faf2

Store id: c0d33108-5380-463f-aa73-4f1ce5d62e1f

## Text

```text
def to_python(self, value)
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
- posted_at: `2026-11-09T23:44:50.0686760+00:00`

## Data

```json
{
  "end_line": 1336,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1333,
  "symbol": "CharField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1333,"selector":"L1333-L1336","symbol":"CharField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1336,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1333,
    "symbol": "CharField.to_python"
  },
  "id": "c0d33108-5380-463f-aa73-4f1ce5d62e1f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0686760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1333,
        "selector": "L1333-L1336",
        "symbol": "CharField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "74462aea-4244-4023-b373-3999f1c70119",
  "subject_name": "django/db/models/fields/__init__::CharField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
