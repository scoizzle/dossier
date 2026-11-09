# Fact 3c206cbb

Store id: 7f229702-5f4e-47bd-ad8a-37d9ec7f4109

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:43.4358580+00:00`

## Data

```json
{
  "end_line": 119,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 79,
  "symbol": "GeneratedField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":79,"selector":"L79-L119","symbol":"GeneratedField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 119,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 79,
    "symbol": "GeneratedField.check"
  },
  "id": "7f229702-5f4e-47bd-ad8a-37d9ec7f4109",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.4358580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 79,
        "selector": "L79-L119",
        "symbol": "GeneratedField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "5e1a9b45-2ffd-4758-b2d9-715960c37759",
  "subject_name": "django/db/models/fields/generated::GeneratedField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
