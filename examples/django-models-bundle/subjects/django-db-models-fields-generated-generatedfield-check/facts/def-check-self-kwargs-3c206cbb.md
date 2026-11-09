# Fact 3c206cbb

Store id: 4914ac50-26c3-45f6-b291-99a581f15d9d

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
- posted_at: `2026-11-09T23:44:50.8072720+00:00`

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
  "id": "4914ac50-26c3-45f6-b291-99a581f15d9d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.8072720+00:00"
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
  "subject_id": "5464aa35-779b-416d-9c71-c1bf9c4c510e",
  "subject_name": "django/db/models/fields/generated::GeneratedField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
