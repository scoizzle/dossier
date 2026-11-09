# Fact 67a366ef

Store id: 42463803-6865-4e1e-8f6a-05cbf4aaff3a

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
- posted_at: `2026-11-09T22:39:42.4740220+00:00`

## Data

```json
{
  "end_line": 1973,
  "entity_kind": "method",
  "parent": "DurationField",
  "start_line": 1956,
  "symbol": "DurationField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1956,"selector":"L1956-L1973","symbol":"DurationField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DurationField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1973,
    "entity_kind": "method",
    "parent": "DurationField",
    "start_line": 1956,
    "symbol": "DurationField.to_python"
  },
  "id": "42463803-6865-4e1e-8f6a-05cbf4aaff3a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4740220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1956,
        "selector": "L1956-L1973",
        "symbol": "DurationField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "3e6a24e1-a036-409c-8bf8-ade7e9136922",
  "subject_name": "django/db/models/fields/__init__::DurationField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
