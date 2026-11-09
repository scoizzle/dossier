# Fact 34304670

Store id: 558fdc4d-c6c3-4dac-92ba-cfc2fff3e0c6

## Text

```text
def process_lhs(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:50.9900170+00:00`

## Data

```json
{
  "end_line": 306,
  "entity_kind": "method",
  "parent": "CaseInsensitiveMixin",
  "start_line": 302,
  "symbol": "CaseInsensitiveMixin.process_lhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":302,"selector":"L302-L306","symbol":"CaseInsensitiveMixin.process_lhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::CaseInsensitiveMixin.process_lhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 306,
    "entity_kind": "method",
    "parent": "CaseInsensitiveMixin",
    "start_line": 302,
    "symbol": "CaseInsensitiveMixin.process_lhs"
  },
  "id": "558fdc4d-c6c3-4dac-92ba-cfc2fff3e0c6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9900170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 302,
        "selector": "L302-L306",
        "symbol": "CaseInsensitiveMixin.process_lhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "4cc39b8e-18c1-4a69-bc8e-7ca4ee18cc6e",
  "subject_name": "django/db/models/fields/json::CaseInsensitiveMixin.process_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_lhs(self, compiler, connection)"
}
```
