# Fact 791fc545

Store id: f994849d-3ff7-409c-af54-c35b32867e22

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
- posted_at: `2026-11-09T23:31:56.5818440+00:00`

## Data

```json
{
  "end_line": 1548,
  "entity_kind": "method",
  "parent": "DateField",
  "start_line": 1520,
  "symbol": "DateField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1520,"selector":"L1520-L1548","symbol":"DateField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1548,
    "entity_kind": "method",
    "parent": "DateField",
    "start_line": 1520,
    "symbol": "DateField.to_python"
  },
  "id": "f994849d-3ff7-409c-af54-c35b32867e22",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5818440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1520,
        "selector": "L1520-L1548",
        "symbol": "DateField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "fe1d7a9b-1834-452a-93c3-df3758b966b4",
  "subject_name": "django/db/models/fields/__init__::DateField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
