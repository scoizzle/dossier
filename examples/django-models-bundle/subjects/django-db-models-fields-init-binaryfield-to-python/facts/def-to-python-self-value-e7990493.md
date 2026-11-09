# Fact e7990493

Store id: 6434be9b-8bdf-40d7-8ac7-e463b6152302

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
- posted_at: `2026-11-09T23:31:56.8685850+00:00`

## Data

```json
{
  "end_line": 2816,
  "entity_kind": "method",
  "parent": "BinaryField",
  "start_line": 2804,
  "symbol": "BinaryField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2804,"selector":"L2804-L2816","symbol":"BinaryField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2816,
    "entity_kind": "method",
    "parent": "BinaryField",
    "start_line": 2804,
    "symbol": "BinaryField.to_python"
  },
  "id": "6434be9b-8bdf-40d7-8ac7-e463b6152302",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8685850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2804,
        "selector": "L2804-L2816",
        "symbol": "BinaryField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "581dab35-8c41-4337-b647-b69912cd2089",
  "subject_name": "django/db/models/fields/__init__::BinaryField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
