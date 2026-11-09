# Fact fd46faf2

Store id: b678d031-dde3-4a54-80f3-40307d859e40

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
- posted_at: `2026-11-09T23:31:56.5579620+00:00`

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
  "id": "b678d031-dde3-4a54-80f3-40307d859e40",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5579620+00:00"
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
  "subject_id": "441d5000-9338-4ce7-ad5b-71bc26eee85d",
  "subject_name": "django/db/models/fields/__init__::CharField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
