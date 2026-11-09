# Fact 3c70840f

Store id: a0d3a258-ac25-4d56-99e3-d6fd9fa291ab

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
- posted_at: `2026-11-09T23:44:50.1971350+00:00`

## Data

```json
{
  "end_line": 2359,
  "entity_kind": "method",
  "parent": "GenericIPAddressField",
  "start_line": 2349,
  "symbol": "GenericIPAddressField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2349,"selector":"L2349-L2359","symbol":"GenericIPAddressField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::GenericIPAddressField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2359,
    "entity_kind": "method",
    "parent": "GenericIPAddressField",
    "start_line": 2349,
    "symbol": "GenericIPAddressField.to_python"
  },
  "id": "a0d3a258-ac25-4d56-99e3-d6fd9fa291ab",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1971350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2349,
        "selector": "L2349-L2359",
        "symbol": "GenericIPAddressField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "6d30cf78-4c1a-4c16-838f-d78f700d6dc3",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
